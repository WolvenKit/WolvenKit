using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animConditionalSegmentCondition : CVariable
	{
		private CInt32 _lod;
		private CName _group;
		private CName _name;
		private CBool _animFeatureValue;

		[Ordinal(0)] 
		[RED("lod")] 
		public CInt32 Lod
		{
			get
			{
				if (_lod == null)
				{
					_lod = (CInt32) CR2WTypeManager.Create("Int32", "lod", cr2w, this);
				}
				return _lod;
			}
			set
			{
				if (_lod == value)
				{
					return;
				}
				_lod = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("group")] 
		public CName Group
		{
			get
			{
				if (_group == null)
				{
					_group = (CName) CR2WTypeManager.Create("CName", "group", cr2w, this);
				}
				return _group;
			}
			set
			{
				if (_group == value)
				{
					return;
				}
				_group = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("animFeatureValue")] 
		public CBool AnimFeatureValue
		{
			get
			{
				if (_animFeatureValue == null)
				{
					_animFeatureValue = (CBool) CR2WTypeManager.Create("Bool", "animFeatureValue", cr2w, this);
				}
				return _animFeatureValue;
			}
			set
			{
				if (_animFeatureValue == value)
				{
					return;
				}
				_animFeatureValue = value;
				PropertySet(this);
			}
		}

		public animConditionalSegmentCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
