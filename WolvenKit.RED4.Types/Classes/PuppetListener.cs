using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PuppetListener : IScriptable
	{
		private CHandle<gamePrereqState> _prereqOwner;

		[Ordinal(0)] 
		[RED("prereqOwner")] 
		public CHandle<gamePrereqState> PrereqOwner
		{
			get => GetProperty(ref _prereqOwner);
			set => SetProperty(ref _prereqOwner, value);
		}
	}
}
