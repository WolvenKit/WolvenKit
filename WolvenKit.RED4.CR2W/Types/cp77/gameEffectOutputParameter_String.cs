using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectOutputParameter_String : CVariable
	{
		private gameBlackboardPropertyBindingDefinition _blackboardProperty;

		[Ordinal(0)] 
		[RED("blackboardProperty")] 
		public gameBlackboardPropertyBindingDefinition BlackboardProperty
		{
			get => GetProperty(ref _blackboardProperty);
			set => SetProperty(ref _blackboardProperty, value);
		}

		public gameEffectOutputParameter_String(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
