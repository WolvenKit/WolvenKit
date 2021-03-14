using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterDataPrereq : gameIScriptablePrereq
	{
		private TweakDBID _idToCheck;

		[Ordinal(0)] 
		[RED("idToCheck")] 
		public TweakDBID IdToCheck
		{
			get
			{
				if (_idToCheck == null)
				{
					_idToCheck = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "idToCheck", cr2w, this);
				}
				return _idToCheck;
			}
			set
			{
				if (_idToCheck == value)
				{
					return;
				}
				_idToCheck = value;
				PropertySet(this);
			}
		}

		public CharacterDataPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
