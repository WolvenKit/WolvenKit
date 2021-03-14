using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SmartHouseConfiguration : CVariable
	{
		private CBool _enableInteraction;
		private CName _factName;

		[Ordinal(0)] 
		[RED("enableInteraction")] 
		public CBool EnableInteraction
		{
			get
			{
				if (_enableInteraction == null)
				{
					_enableInteraction = (CBool) CR2WTypeManager.Create("Bool", "enableInteraction", cr2w, this);
				}
				return _enableInteraction;
			}
			set
			{
				if (_enableInteraction == value)
				{
					return;
				}
				_enableInteraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("factName")] 
		public CName FactName
		{
			get
			{
				if (_factName == null)
				{
					_factName = (CName) CR2WTypeManager.Create("CName", "factName", cr2w, this);
				}
				return _factName;
			}
			set
			{
				if (_factName == value)
				{
					return;
				}
				_factName = value;
				PropertySet(this);
			}
		}

		public SmartHouseConfiguration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
