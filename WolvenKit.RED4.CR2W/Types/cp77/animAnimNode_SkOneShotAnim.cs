using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkOneShotAnim : animAnimNode_SkAnim
	{
		private animPoseLink _input;
		private CFloat _blendIn;
		private CFloat _blendOut;

		[Ordinal(30)] 
		[RED("Input")] 
		public animPoseLink Input
		{
			get
			{
				if (_input == null)
				{
					_input = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "Input", cr2w, this);
				}
				return _input;
			}
			set
			{
				if (_input == value)
				{
					return;
				}
				_input = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("blendIn")] 
		public CFloat BlendIn
		{
			get
			{
				if (_blendIn == null)
				{
					_blendIn = (CFloat) CR2WTypeManager.Create("Float", "blendIn", cr2w, this);
				}
				return _blendIn;
			}
			set
			{
				if (_blendIn == value)
				{
					return;
				}
				_blendIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("blendOut")] 
		public CFloat BlendOut
		{
			get
			{
				if (_blendOut == null)
				{
					_blendOut = (CFloat) CR2WTypeManager.Create("Float", "blendOut", cr2w, this);
				}
				return _blendOut;
			}
			set
			{
				if (_blendOut == value)
				{
					return;
				}
				_blendOut = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SkOneShotAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
