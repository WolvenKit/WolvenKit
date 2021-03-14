using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IdentifiedWrappedTooltipData : ATooltipData
	{
		private CName _identifier;
		private CHandle<ATooltipData> _data;

		[Ordinal(0)] 
		[RED("identifier")] 
		public CName Identifier
		{
			get
			{
				if (_identifier == null)
				{
					_identifier = (CName) CR2WTypeManager.Create("CName", "identifier", cr2w, this);
				}
				return _identifier;
			}
			set
			{
				if (_identifier == value)
				{
					return;
				}
				_identifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<ATooltipData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<ATooltipData>) CR2WTypeManager.Create("handle:ATooltipData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public IdentifiedWrappedTooltipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
