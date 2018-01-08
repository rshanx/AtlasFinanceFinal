﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;


namespace SchedulerServer.AltechNuPay.Report
{
  public static class FileStructureHelper
  {
    public static void TrimElementValues(ref XElement item)
    {
      foreach (var element in item.Elements())
      {
        element.Value = element.Value.Trim();
      }
    }


    public static decimal ConvertFromCents(string value)
    {
      return ((decimal)Int64.Parse(value, CultureInfo.InvariantCulture)) / 100M;
    }


    public static bool IsEmpty(XElement transaction)
    {
      return (transaction.Element("empty") != null);
    }


    public static bool IsError(XElement result, out string error)
    {
      if (result == null)
      {
        error = "No data was returned from the source system";
        return true;
      }

      error = null;
      var xmlError = result.Element("ReportError");
      if (xmlError == null)
      {
        return false;
      }

      try
      {
        var errorCode = xmlError.Element("error_code").Value;
        var errorMsg = xmlError.Element("error_msg").Value;
        var errorDetail = xmlError.Element("error_detail").Value;

        error = string.Format("Error '{0}', code: {1} at '{2}'", errorMsg, errorCode, errorDetail);
      }
      catch
      {
        error = "Error XML is missing expected nodes";
      }

      return true;
    }


    public class XElementValueEqualityComparer : IEqualityComparer<XElement>
    {
      public bool Equals(XElement x, XElement y)
      {
        return x.Value.Equals(y.Value);
      }

      public int GetHashCode(XElement x)
      {
        return x.Value.GetHashCode();
      }
    }

  }

}