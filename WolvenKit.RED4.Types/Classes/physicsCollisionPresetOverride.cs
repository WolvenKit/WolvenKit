using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsCollisionPresetOverride : RedBaseClass
	{
		private CName _from;
		private CName _to;

		[Ordinal(0)] 
		[RED("from")] 
		public CName From
		{
			get => GetProperty(ref _from);
			set => SetProperty(ref _from, value);
		}

		[Ordinal(1)] 
		[RED("to")] 
		public CName To
		{
			get => GetProperty(ref _to);
			set => SetProperty(ref _to, value);
		}
	}
}
