using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPersistentSnapData : CVariable
	{
		private worldRelativeNodePath _targetObjectPath;
		private CName _targetSocketName;
		private CBool _snapTangent;
		private CBool _reverseTangent;
		private CBool _preserveLength;

		[Ordinal(0)] 
		[RED("targetObjectPath")] 
		public worldRelativeNodePath TargetObjectPath
		{
			get
			{
				if (_targetObjectPath == null)
				{
					_targetObjectPath = (worldRelativeNodePath) CR2WTypeManager.Create("worldRelativeNodePath", "targetObjectPath", cr2w, this);
				}
				return _targetObjectPath;
			}
			set
			{
				if (_targetObjectPath == value)
				{
					return;
				}
				_targetObjectPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("targetSocketName")] 
		public CName TargetSocketName
		{
			get
			{
				if (_targetSocketName == null)
				{
					_targetSocketName = (CName) CR2WTypeManager.Create("CName", "targetSocketName", cr2w, this);
				}
				return _targetSocketName;
			}
			set
			{
				if (_targetSocketName == value)
				{
					return;
				}
				_targetSocketName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("snapTangent")] 
		public CBool SnapTangent
		{
			get
			{
				if (_snapTangent == null)
				{
					_snapTangent = (CBool) CR2WTypeManager.Create("Bool", "snapTangent", cr2w, this);
				}
				return _snapTangent;
			}
			set
			{
				if (_snapTangent == value)
				{
					return;
				}
				_snapTangent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("reverseTangent")] 
		public CBool ReverseTangent
		{
			get
			{
				if (_reverseTangent == null)
				{
					_reverseTangent = (CBool) CR2WTypeManager.Create("Bool", "reverseTangent", cr2w, this);
				}
				return _reverseTangent;
			}
			set
			{
				if (_reverseTangent == value)
				{
					return;
				}
				_reverseTangent = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("preserveLength")] 
		public CBool PreserveLength
		{
			get
			{
				if (_preserveLength == null)
				{
					_preserveLength = (CBool) CR2WTypeManager.Create("Bool", "preserveLength", cr2w, this);
				}
				return _preserveLength;
			}
			set
			{
				if (_preserveLength == value)
				{
					return;
				}
				_preserveLength = value;
				PropertySet(this);
			}
		}

		public worldPersistentSnapData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
