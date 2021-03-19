using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SubCharEquipRequest : gameEquipRequest
	{
		private CEnum<gamedataSubCharacter> _subCharType;

		[Ordinal(5)] 
		[RED("subCharType")] 
		public CEnum<gamedataSubCharacter> SubCharType
		{
			get => GetProperty(ref _subCharType);
			set => SetProperty(ref _subCharType, value);
		}

		public SubCharEquipRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
