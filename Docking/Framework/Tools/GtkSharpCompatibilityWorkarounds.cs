// Ubuntu 12.04 LTS currently only has an outdated GTK# binary delivery,
// lacking these functions. We inject them here as a workaround.
// We hope that at some point of time in the future, Ubuntu will contain an updated GTK# version
// which contains these functions.

#if __MonoCS__ // http://stackoverflow.com/questions/329043/how-can-i-conditionally-compile-my-c-sharp-for-mono-vs-microsoft-net

using System;
using Cairo;

namespace Docking // TODO use a different namespace
{
	public static class GtkSharpCompatibilityWorkarounds
	{
		public static void SetSource(this Context context, Surface surface)
		{
			context.SetSourceSurface(surface, 0, 0);
		}
		
		public static Surface GetTarget(this Context context)
		{
			return context.GetTarget();
		}
		
		public static void SetSource(this Context context, Pattern pattern)
		{
			//throw new Exception("implement me");
		}
		
		public static void Dispose(this Context context)
		{
			//throw new Exception("implement me");
		}
	}
	
}

#endif