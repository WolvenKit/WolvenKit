using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DevelopmentCheckPrereq : gameIScriptablePrereq
	{
		private CFloat _requiredLevel;

		[Ordinal(0)] 
		[RED("requiredLevel")] 
		public CFloat RequiredLevel
		{
			get
			{
				if (_requiredLevel == null)
				{
					_requiredLevel = (CFloat) CR2WTypeManager.Create("Float", "requiredLevel", cr2w, this);
				}
				return _requiredLevel;
			}
			set
			{
				if (_requiredLevel == value)
				{
					return;
				}
				_requiredLevel = value;
				PropertySet(this);
			}
		}

		public DevelopmentCheckPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
