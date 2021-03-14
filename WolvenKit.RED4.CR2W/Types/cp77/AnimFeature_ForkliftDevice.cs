using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_ForkliftDevice : animAnimFeature
	{
		private CBool _isUp;
		private CBool _isDown;
		private CBool _distract;

		[Ordinal(0)] 
		[RED("isUp")] 
		public CBool IsUp
		{
			get
			{
				if (_isUp == null)
				{
					_isUp = (CBool) CR2WTypeManager.Create("Bool", "isUp", cr2w, this);
				}
				return _isUp;
			}
			set
			{
				if (_isUp == value)
				{
					return;
				}
				_isUp = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isDown")] 
		public CBool IsDown
		{
			get
			{
				if (_isDown == null)
				{
					_isDown = (CBool) CR2WTypeManager.Create("Bool", "isDown", cr2w, this);
				}
				return _isDown;
			}
			set
			{
				if (_isDown == value)
				{
					return;
				}
				_isDown = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("distract")] 
		public CBool Distract
		{
			get
			{
				if (_distract == null)
				{
					_distract = (CBool) CR2WTypeManager.Create("Bool", "distract", cr2w, this);
				}
				return _distract;
			}
			set
			{
				if (_distract == value)
				{
					return;
				}
				_distract = value;
				PropertySet(this);
			}
		}

		public AnimFeature_ForkliftDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
