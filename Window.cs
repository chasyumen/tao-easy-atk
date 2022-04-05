namespace tao_easy_atk;
using System.Runtime.InteropServices;

public partial class Window : Form
{
    public static Boolean isRunning = false;
    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    static extern bool AllocConsole();

    [DllImport("user32.dll")] 
    public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
    [DllImport("user32.dll")]
    public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
    const int MYACTION_HOTKEY_ID = 1;
    public Window()
    {
        // AllocConsole();

        InitializeComponent();
        RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 0, (int) Keys.Enter);
    }

    protected override void WndProc(ref Message m) {
        if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID) {
            if (m.Msg == 786) {
                UnregisterHotKey(this.Handle, MYACTION_HOTKEY_ID);
                if (isRunning == true) {
                    SendKeys.Send("::atk{Enter}");
                } else {
                    SendKeys.Send("{Enter}");
                }
                RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 0, (int) Keys.Enter);
            }
            // My hotkey has been typed
            // Console.Write(m.Msg);
            // Do what you want here
            // ...
        }
        base.WndProc(ref m);
        // return;
    }
}