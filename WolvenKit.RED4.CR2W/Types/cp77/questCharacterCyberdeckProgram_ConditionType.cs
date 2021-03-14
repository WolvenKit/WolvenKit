using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterCyberdeckProgram_ConditionType : questICharacterConditionType
	{
		private TweakDBID _cyberdeckProgramID;

		[Ordinal(0)] 
		[RED("cyberdeckProgramID")] 
		public TweakDBID CyberdeckProgramID
		{
			get
			{
				if (_cyberdeckProgramID == null)
				{
					_cyberdeckProgramID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "cyberdeckProgramID", cr2w, this);
				}
				return _cyberdeckProgramID;
			}
			set
			{
				if (_cyberdeckProgramID == value)
				{
					return;
				}
				_cyberdeckProgramID = value;
				PropertySet(this);
			}
		}

		public questCharacterCyberdeckProgram_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
