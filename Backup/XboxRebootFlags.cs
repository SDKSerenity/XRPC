﻿// Decompiled with JetBrains decompiler
// Type: XDevkit.XboxRebootFlags
// Assembly: XRPC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 76786C01-8B8F-460F-885C-89B2A0240B23
// Assembly location: C:\Users\Serenity\Desktop\XRPC.dll

using System.Runtime.InteropServices;

namespace XDevkit
{
  [ComVisible(true)]
  public enum XboxRebootFlags
  {
    Title = 0,
    Wait = 1,
    Cold = 2,
    Warm = 4,
    Stop = 8,
  }
}
