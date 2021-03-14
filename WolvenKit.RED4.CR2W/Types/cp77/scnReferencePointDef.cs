using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnReferencePointDef : CVariable
	{
		private scnReferencePointId _id;
		private Vector3 _offset;
		private scnMarker _originMarker;

		[Ordinal(0)] 
		[RED("id")] 
		public scnReferencePointId Id
		{
			get
			{
				if (_id == null)
				{
					_id = (scnReferencePointId) CR2WTypeManager.Create("scnReferencePointId", "id", cr2w, this);
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
		[RED("offset")] 
		public Vector3 Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Vector3) CR2WTypeManager.Create("Vector3", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("originMarker")] 
		public scnMarker OriginMarker
		{
			get
			{
				if (_originMarker == null)
				{
					_originMarker = (scnMarker) CR2WTypeManager.Create("scnMarker", "originMarker", cr2w, this);
				}
				return _originMarker;
			}
			set
			{
				if (_originMarker == value)
				{
					return;
				}
				_originMarker = value;
				PropertySet(this);
			}
		}

		public scnReferencePointDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
