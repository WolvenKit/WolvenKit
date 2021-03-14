using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtPartRequest : CVariable
	{
		private CName _partName;
		private CFloat _weight;
		private CFloat _suppress;
		private CInt32 _mode;

		[Ordinal(0)] 
		[RED("partName")] 
		public CName PartName
		{
			get
			{
				if (_partName == null)
				{
					_partName = (CName) CR2WTypeManager.Create("CName", "partName", cr2w, this);
				}
				return _partName;
			}
			set
			{
				if (_partName == value)
				{
					return;
				}
				_partName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get
			{
				if (_weight == null)
				{
					_weight = (CFloat) CR2WTypeManager.Create("Float", "weight", cr2w, this);
				}
				return _weight;
			}
			set
			{
				if (_weight == value)
				{
					return;
				}
				_weight = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("suppress")] 
		public CFloat Suppress
		{
			get
			{
				if (_suppress == null)
				{
					_suppress = (CFloat) CR2WTypeManager.Create("Float", "suppress", cr2w, this);
				}
				return _suppress;
			}
			set
			{
				if (_suppress == value)
				{
					return;
				}
				_suppress = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("mode")] 
		public CInt32 Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CInt32) CR2WTypeManager.Create("Int32", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		public animLookAtPartRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
