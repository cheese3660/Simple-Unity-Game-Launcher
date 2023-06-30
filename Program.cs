using System.Runtime.InteropServices;
using System.Diagnostics;

[DllImport("UnityPlayer")]
static extern int UnityMain(IntPtr hInstance, IntPtr hPrevInstance,
    [MarshalAs(UnmanagedType.LPWStr)]ref string lpCmdline, int nShowCmd);

var commandArgs = string.Join(' ', args);
UnityMain(Process.GetCurrentProcess().Handle,IntPtr.Zero,ref commandArgs,0);