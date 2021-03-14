using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerSphereAligned : IParticleDrawer
	{
		private CBool _verticalFixed;
		private CBool _isGPUBased;

		[Ordinal(1)] 
		[RED("verticalFixed")] 
		public CBool VerticalFixed
		{
			get
			{
				if (_verticalFixed == null)
				{
					_verticalFixed = (CBool) CR2WTypeManager.Create("Bool", "verticalFixed", cr2w, this);
				}
				return _verticalFixed;
			}
			set
			{
				if (_verticalFixed == value)
				{
					return;
				}
				_verticalFixed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isGPUBased")] 
		public CBool IsGPUBased
		{
			get
			{
				if (_isGPUBased == null)
				{
					_isGPUBased = (CBool) CR2WTypeManager.Create("Bool", "isGPUBased", cr2w, this);
				}
				return _isGPUBased;
			}
			set
			{
				if (_isGPUBased == value)
				{
					return;
				}
				_isGPUBased = value;
				PropertySet(this);
			}
		}

		public CParticleDrawerSphereAligned(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
