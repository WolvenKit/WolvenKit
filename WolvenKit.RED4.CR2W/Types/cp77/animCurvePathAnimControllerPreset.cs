using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animCurvePathAnimControllerPreset : CVariable
	{
		private CName _name;
		private CName _leftAnimationName;
		private CName _forwardAnimationName;
		private CName _rightAnimationName;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("leftAnimationName")] 
		public CName LeftAnimationName
		{
			get
			{
				if (_leftAnimationName == null)
				{
					_leftAnimationName = (CName) CR2WTypeManager.Create("CName", "leftAnimationName", cr2w, this);
				}
				return _leftAnimationName;
			}
			set
			{
				if (_leftAnimationName == value)
				{
					return;
				}
				_leftAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("forwardAnimationName")] 
		public CName ForwardAnimationName
		{
			get
			{
				if (_forwardAnimationName == null)
				{
					_forwardAnimationName = (CName) CR2WTypeManager.Create("CName", "forwardAnimationName", cr2w, this);
				}
				return _forwardAnimationName;
			}
			set
			{
				if (_forwardAnimationName == value)
				{
					return;
				}
				_forwardAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rightAnimationName")] 
		public CName RightAnimationName
		{
			get
			{
				if (_rightAnimationName == null)
				{
					_rightAnimationName = (CName) CR2WTypeManager.Create("CName", "rightAnimationName", cr2w, this);
				}
				return _rightAnimationName;
			}
			set
			{
				if (_rightAnimationName == value)
				{
					return;
				}
				_rightAnimationName = value;
				PropertySet(this);
			}
		}

		public animCurvePathAnimControllerPreset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
