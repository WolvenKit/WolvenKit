using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_MeleeIKData : animAnimFeature
	{
		private CBool _isValid;
		private Vector4 _headPosition;
		private Vector4 _chestPosition;
		private Vector4 _ikOffset;

		[Ordinal(0)] 
		[RED("isValid")] 
		public CBool IsValid
		{
			get
			{
				if (_isValid == null)
				{
					_isValid = (CBool) CR2WTypeManager.Create("Bool", "isValid", cr2w, this);
				}
				return _isValid;
			}
			set
			{
				if (_isValid == value)
				{
					return;
				}
				_isValid = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("headPosition")] 
		public Vector4 HeadPosition
		{
			get
			{
				if (_headPosition == null)
				{
					_headPosition = (Vector4) CR2WTypeManager.Create("Vector4", "headPosition", cr2w, this);
				}
				return _headPosition;
			}
			set
			{
				if (_headPosition == value)
				{
					return;
				}
				_headPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("chestPosition")] 
		public Vector4 ChestPosition
		{
			get
			{
				if (_chestPosition == null)
				{
					_chestPosition = (Vector4) CR2WTypeManager.Create("Vector4", "chestPosition", cr2w, this);
				}
				return _chestPosition;
			}
			set
			{
				if (_chestPosition == value)
				{
					return;
				}
				_chestPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ikOffset")] 
		public Vector4 IkOffset
		{
			get
			{
				if (_ikOffset == null)
				{
					_ikOffset = (Vector4) CR2WTypeManager.Create("Vector4", "ikOffset", cr2w, this);
				}
				return _ikOffset;
			}
			set
			{
				if (_ikOffset == value)
				{
					return;
				}
				_ikOffset = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_MeleeIKData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
