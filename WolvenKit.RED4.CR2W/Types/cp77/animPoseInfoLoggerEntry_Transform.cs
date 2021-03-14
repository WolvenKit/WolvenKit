using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseInfoLoggerEntry_Transform : animPoseInfoLoggerEntry
	{
		private animTransformIndex _transform;
		private CBool _logInModelSpace;

		[Ordinal(0)] 
		[RED("transform")] 
		public animTransformIndex Transform
		{
			get
			{
				if (_transform == null)
				{
					_transform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "transform", cr2w, this);
				}
				return _transform;
			}
			set
			{
				if (_transform == value)
				{
					return;
				}
				_transform = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("logInModelSpace")] 
		public CBool LogInModelSpace
		{
			get
			{
				if (_logInModelSpace == null)
				{
					_logInModelSpace = (CBool) CR2WTypeManager.Create("Bool", "logInModelSpace", cr2w, this);
				}
				return _logInModelSpace;
			}
			set
			{
				if (_logInModelSpace == value)
				{
					return;
				}
				_logInModelSpace = value;
				PropertySet(this);
			}
		}

		public animPoseInfoLoggerEntry_Transform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
