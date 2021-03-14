using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class localizationPersistenceCLNumberDateContainer : ISerializable
	{
		private CName _clNumber;
		private CName _clTimestamp;

		[Ordinal(0)] 
		[RED("clNumber")] 
		public CName ClNumber
		{
			get
			{
				if (_clNumber == null)
				{
					_clNumber = (CName) CR2WTypeManager.Create("CName", "clNumber", cr2w, this);
				}
				return _clNumber;
			}
			set
			{
				if (_clNumber == value)
				{
					return;
				}
				_clNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("clTimestamp")] 
		public CName ClTimestamp
		{
			get
			{
				if (_clTimestamp == null)
				{
					_clTimestamp = (CName) CR2WTypeManager.Create("CName", "clTimestamp", cr2w, this);
				}
				return _clTimestamp;
			}
			set
			{
				if (_clTimestamp == value)
				{
					return;
				}
				_clTimestamp = value;
				PropertySet(this);
			}
		}

		public localizationPersistenceCLNumberDateContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
