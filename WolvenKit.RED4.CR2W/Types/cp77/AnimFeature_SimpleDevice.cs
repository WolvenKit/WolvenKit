using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SimpleDevice : animAnimFeatureMarkUnstable
	{
		private CBool _isOpen;
		private CBool _isOpenLeft;
		private CBool _isOpenRight;

		[Ordinal(0)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get
			{
				if (_isOpen == null)
				{
					_isOpen = (CBool) CR2WTypeManager.Create("Bool", "isOpen", cr2w, this);
				}
				return _isOpen;
			}
			set
			{
				if (_isOpen == value)
				{
					return;
				}
				_isOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isOpenLeft")] 
		public CBool IsOpenLeft
		{
			get
			{
				if (_isOpenLeft == null)
				{
					_isOpenLeft = (CBool) CR2WTypeManager.Create("Bool", "isOpenLeft", cr2w, this);
				}
				return _isOpenLeft;
			}
			set
			{
				if (_isOpenLeft == value)
				{
					return;
				}
				_isOpenLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isOpenRight")] 
		public CBool IsOpenRight
		{
			get
			{
				if (_isOpenRight == null)
				{
					_isOpenRight = (CBool) CR2WTypeManager.Create("Bool", "isOpenRight", cr2w, this);
				}
				return _isOpenRight;
			}
			set
			{
				if (_isOpenRight == value)
				{
					return;
				}
				_isOpenRight = value;
				PropertySet(this);
			}
		}

		public AnimFeature_SimpleDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
