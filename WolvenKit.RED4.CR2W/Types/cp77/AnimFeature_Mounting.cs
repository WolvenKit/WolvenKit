using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Mounting : animAnimFeature
	{
		private CInt32 _mountingState;
		private CFloat _parentSpeed;

		[Ordinal(0)] 
		[RED("mountingState")] 
		public CInt32 MountingState
		{
			get
			{
				if (_mountingState == null)
				{
					_mountingState = (CInt32) CR2WTypeManager.Create("Int32", "mountingState", cr2w, this);
				}
				return _mountingState;
			}
			set
			{
				if (_mountingState == value)
				{
					return;
				}
				_mountingState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("parentSpeed")] 
		public CFloat ParentSpeed
		{
			get
			{
				if (_parentSpeed == null)
				{
					_parentSpeed = (CFloat) CR2WTypeManager.Create("Float", "parentSpeed", cr2w, this);
				}
				return _parentSpeed;
			}
			set
			{
				if (_parentSpeed == value)
				{
					return;
				}
				_parentSpeed = value;
				PropertySet(this);
			}
		}

		public AnimFeature_Mounting(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
