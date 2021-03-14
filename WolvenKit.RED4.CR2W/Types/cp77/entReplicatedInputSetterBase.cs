using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entReplicatedInputSetterBase : CVariable
	{
		private CName _name;
		private netTime _applyServerTime;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("applyServerTime")] 
		public netTime ApplyServerTime
		{
			get
			{
				if (_applyServerTime == null)
				{
					_applyServerTime = (netTime) CR2WTypeManager.Create("netTime", "applyServerTime", cr2w, this);
				}
				return _applyServerTime;
			}
			set
			{
				if (_applyServerTime == value)
				{
					return;
				}
				_applyServerTime = value;
				PropertySet(this);
			}
		}

		public entReplicatedInputSetterBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
