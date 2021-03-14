using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animFloatTrackInfo : CVariable
	{
		private CName _name;
		private CFloat _referenceValue;

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
		[RED("referenceValue")] 
		public CFloat ReferenceValue
		{
			get
			{
				if (_referenceValue == null)
				{
					_referenceValue = (CFloat) CR2WTypeManager.Create("Float", "referenceValue", cr2w, this);
				}
				return _referenceValue;
			}
			set
			{
				if (_referenceValue == value)
				{
					return;
				}
				_referenceValue = value;
				PropertySet(this);
			}
		}

		public animFloatTrackInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
