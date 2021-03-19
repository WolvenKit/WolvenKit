using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDrawItemByContextRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<gameItemEquipContexts> _itemEquipContext;
		private CEnum<gameEquipAnimationType> _equipAnimationType;

		[Ordinal(1)] 
		[RED("itemEquipContext")] 
		public CEnum<gameItemEquipContexts> ItemEquipContext
		{
			get => GetProperty(ref _itemEquipContext);
			set => SetProperty(ref _itemEquipContext, value);
		}

		[Ordinal(2)] 
		[RED("equipAnimationType")] 
		public CEnum<gameEquipAnimationType> EquipAnimationType
		{
			get => GetProperty(ref _equipAnimationType);
			set => SetProperty(ref _equipAnimationType, value);
		}

		public gameDrawItemByContextRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
