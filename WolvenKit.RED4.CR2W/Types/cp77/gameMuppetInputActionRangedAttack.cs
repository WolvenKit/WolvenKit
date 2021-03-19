using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputActionRangedAttack : gameIMuppetInputAction
	{
		private CEnum<gameMuppetInputActionType> _actionType;

		[Ordinal(0)] 
		[RED("actionType")] 
		public CEnum<gameMuppetInputActionType> ActionType
		{
			get => GetProperty(ref _actionType);
			set => SetProperty(ref _actionType, value);
		}

		public gameMuppetInputActionRangedAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
