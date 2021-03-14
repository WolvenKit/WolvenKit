using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraDeadBodyInternalData : IScriptable
	{
		private entEntityID _ownerID;
		private CArray<entEntityID> _bodyIDs;

		[Ordinal(0)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get
			{
				if (_ownerID == null)
				{
					_ownerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "ownerID", cr2w, this);
				}
				return _ownerID;
			}
			set
			{
				if (_ownerID == value)
				{
					return;
				}
				_ownerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("bodyIDs")] 
		public CArray<entEntityID> BodyIDs
		{
			get
			{
				if (_bodyIDs == null)
				{
					_bodyIDs = (CArray<entEntityID>) CR2WTypeManager.Create("array:entEntityID", "bodyIDs", cr2w, this);
				}
				return _bodyIDs;
			}
			set
			{
				if (_bodyIDs == value)
				{
					return;
				}
				_bodyIDs = value;
				PropertySet(this);
			}
		}

		public CameraDeadBodyInternalData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
