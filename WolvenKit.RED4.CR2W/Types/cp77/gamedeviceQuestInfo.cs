using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedeviceQuestInfo : CVariable
	{
		private CBool _isHighlighted;
		private CName _factName;

		[Ordinal(0)] 
		[RED("isHighlighted")] 
		public CBool IsHighlighted
		{
			get
			{
				if (_isHighlighted == null)
				{
					_isHighlighted = (CBool) CR2WTypeManager.Create("Bool", "isHighlighted", cr2w, this);
				}
				return _isHighlighted;
			}
			set
			{
				if (_isHighlighted == value)
				{
					return;
				}
				_isHighlighted = value;
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

		public gamedeviceQuestInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
