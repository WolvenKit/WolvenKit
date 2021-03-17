using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinotaurOnStatusEffectAppliedListener : gameScriptStatusEffectListener
	{
		private wCHandle<NPCPuppet> _owner;
		private CHandle<MinotaurMechComponent> _minotaurMechComponent;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<NPCPuppet> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("minotaurMechComponent")] 
		public CHandle<MinotaurMechComponent> MinotaurMechComponent
		{
			get => GetProperty(ref _minotaurMechComponent);
			set => SetProperty(ref _minotaurMechComponent, value);
		}

		public MinotaurOnStatusEffectAppliedListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
