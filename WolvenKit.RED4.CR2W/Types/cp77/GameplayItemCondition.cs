using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayItemCondition : GameplayConditionBase
	{
		private TweakDBID _itemToCheck;

		[Ordinal(1)] 
		[RED("itemToCheck")] 
		public TweakDBID ItemToCheck
		{
			get => GetProperty(ref _itemToCheck);
			set => SetProperty(ref _itemToCheck, value);
		}

		public GameplayItemCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
