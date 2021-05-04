using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBlackboardChangedEvent : redEvent
	{
		private CHandle<gamebbScriptDefinition> _definition;
		private gamebbScriptID _id;

		[Ordinal(0)] 
		[RED("definition")] 
		public CHandle<gamebbScriptDefinition> Definition
		{
			get => GetProperty(ref _definition);
			set => SetProperty(ref _definition, value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public gamebbScriptID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		public gameBlackboardChangedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
