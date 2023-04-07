// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Oi seja bem vindo ao ANTI-AFK!");
[DllImport("user32.dll")]
static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);


    // Código das teclas Alt e Tab
    const byte VK_MENU = 0x12; // Alt key
    const byte VK_TAB = 0x09;

    // Tempo em segundos entre as iterações do loop
    int intervalo = 10;
while (true)
{
    // Pressiona a tecla Alt
    keybd_event(VK_MENU, 0, 0, UIntPtr.Zero);

    // Pressiona a tecla Tab
    keybd_event(VK_TAB, 0, 0, UIntPtr.Zero);

    // Libera a tecla Tab
    keybd_event(VK_TAB, 0, 0x0002, UIntPtr.Zero);

    // Libera a tecla Alt
    keybd_event(VK_MENU, 0, 0x0002, UIntPtr.Zero);

    Console.WriteLine("Combinação de teclas Alt+Tab pressionada.");
    Thread.Sleep(intervalo * 1000);
}