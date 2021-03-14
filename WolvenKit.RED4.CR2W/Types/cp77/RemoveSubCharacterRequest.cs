using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveSubCharacterRequest : gameScriptableSystemRequest
	{
		private CEnum<gamedataSubCharacter> _subCharType;

		[Ordinal(0)] 
		[RED("subCharType")] 
		public CEnum<gamedataSubCharacter> SubCharType
		{
			get
			{
				if (_subCharType == null)
				{
					_subCharType = (CEnum<gamedataSubCharacter>) CR2WTypeManager.Create("gamedataSubCharacter", "subCharType", cr2w, this);
				}
				return _subCharType;
			}
			set
			{
				if (_subCharType == value)
				{
					return;
				}
				_subCharType = value;
				PropertySet(this);
			}
		}

		public RemoveSubCharacterRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
