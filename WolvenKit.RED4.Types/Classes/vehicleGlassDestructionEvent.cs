using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleGlassDestructionEvent : redEvent
	{
		private CName _glassName;

		[Ordinal(0)] 
		[RED("glassName")] 
		public CName GlassName
		{
			get => GetProperty(ref _glassName);
			set => SetProperty(ref _glassName, value);
		}
	}
}
