using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LookAtApplyVehicleRestrictions : animAnimNode_OnePoseInput
	{
		private CName _group;
		private CName _name;
		private animTransformIndex _referenceBone;

		[Ordinal(12)] 
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

		[Ordinal(13)] 
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

		[Ordinal(14)] 
		[RED("referenceBone")] 
		public animTransformIndex ReferenceBone
		{
			get
			{
				if (_referenceBone == null)
				{
					_referenceBone = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "referenceBone", cr2w, this);
				}
				return _referenceBone;
			}
			set
			{
				if (_referenceBone == value)
				{
					return;
				}
				_referenceBone = value;
				PropertySet(this);
			}
		}

		public animAnimNode_LookAtApplyVehicleRestrictions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
