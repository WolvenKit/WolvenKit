using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAudioSignpostTriggerNode : worldTriggerAreaNode
	{
		private CName _enterSignpost;
		private CName _exitSignpost;
		private CFloat _exitCooldown;

		[Ordinal(7)] 
		[RED("enterSignpost")] 
		public CName EnterSignpost
		{
			get => GetProperty(ref _enterSignpost);
			set => SetProperty(ref _enterSignpost, value);
		}

		[Ordinal(8)] 
		[RED("exitSignpost")] 
		public CName ExitSignpost
		{
			get => GetProperty(ref _exitSignpost);
			set => SetProperty(ref _exitSignpost, value);
		}

		[Ordinal(9)] 
		[RED("exitCooldown")] 
		public CFloat ExitCooldown
		{
			get => GetProperty(ref _exitCooldown);
			set => SetProperty(ref _exitCooldown, value);
		}

		public worldAudioSignpostTriggerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
