using System;
using System.Runtime.InteropServices;

namespace SevenZip.Mono
{
    public static class SevenZip
    {
		private const string nativeLibName = "SDL2.dll";

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr SDL_malloc(IntPtr size);

		[DllImport(nativeLibName, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void SDL_free(IntPtr memblock);

	}
}
