using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class senseVisibleObject : IScriptable
	{
		private CName _description;
		private CFloat _visibilityDistance;
		private CEnum<gamedataSenseObjectType> _visibleObjectType;

		[Ordinal(0)] 
		[RED("description")] 
		public CName Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CName) CR2WTypeManager.Create("CName", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("visibilityDistance")] 
		public CFloat VisibilityDistance
		{
			get
			{
				if (_visibilityDistance == null)
				{
					_visibilityDistance = (CFloat) CR2WTypeManager.Create("Float", "visibilityDistance", cr2w, this);
				}
				return _visibilityDistance;
			}
			set
			{
				if (_visibilityDistance == value)
				{
					return;
				}
				_visibilityDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("visibleObjectType")] 
		public CEnum<gamedataSenseObjectType> VisibleObjectType
		{
			get
			{
				if (_visibleObjectType == null)
				{
					_visibleObjectType = (CEnum<gamedataSenseObjectType>) CR2WTypeManager.Create("gamedataSenseObjectType", "visibleObjectType", cr2w, this);
				}
				return _visibleObjectType;
			}
			set
			{
				if (_visibleObjectType == value)
				{
					return;
				}
				_visibleObjectType = value;
				PropertySet(this);
			}
		}

		public senseVisibleObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
