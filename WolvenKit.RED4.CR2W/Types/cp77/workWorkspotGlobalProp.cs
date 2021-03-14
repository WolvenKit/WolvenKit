using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workWorkspotGlobalProp : CVariable
	{
		private CName _id;
		private CName _boneName;
		private raRef<entEntityTemplate> _prop;

		[Ordinal(0)] 
		[RED("id")] 
		public CName Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CName) CR2WTypeManager.Create("CName", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("boneName")] 
		public CName BoneName
		{
			get
			{
				if (_boneName == null)
				{
					_boneName = (CName) CR2WTypeManager.Create("CName", "boneName", cr2w, this);
				}
				return _boneName;
			}
			set
			{
				if (_boneName == value)
				{
					return;
				}
				_boneName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("prop")] 
		public raRef<entEntityTemplate> Prop
		{
			get
			{
				if (_prop == null)
				{
					_prop = (raRef<entEntityTemplate>) CR2WTypeManager.Create("raRef:entEntityTemplate", "prop", cr2w, this);
				}
				return _prop;
			}
			set
			{
				if (_prop == value)
				{
					return;
				}
				_prop = value;
				PropertySet(this);
			}
		}

		public workWorkspotGlobalProp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
