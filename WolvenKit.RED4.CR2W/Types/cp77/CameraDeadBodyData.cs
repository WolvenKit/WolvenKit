using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraDeadBodyData : IScriptable
	{
		private CEnum<EGameSessionDataType> _dataType;
		private entEntityID _ownerID;
		private entEntityID _bodyID;

		[Ordinal(0)] 
		[RED("dataType")] 
		public CEnum<EGameSessionDataType> DataType
		{
			get
			{
				if (_dataType == null)
				{
					_dataType = (CEnum<EGameSessionDataType>) CR2WTypeManager.Create("EGameSessionDataType", "dataType", cr2w, this);
				}
				return _dataType;
			}
			set
			{
				if (_dataType == value)
				{
					return;
				}
				_dataType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("bodyID")] 
		public entEntityID BodyID
		{
			get
			{
				if (_bodyID == null)
				{
					_bodyID = (entEntityID) CR2WTypeManager.Create("entEntityID", "bodyID", cr2w, this);
				}
				return _bodyID;
			}
			set
			{
				if (_bodyID == value)
				{
					return;
				}
				_bodyID = value;
				PropertySet(this);
			}
		}

		public CameraDeadBodyData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
