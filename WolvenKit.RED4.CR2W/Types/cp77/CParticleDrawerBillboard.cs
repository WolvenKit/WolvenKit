using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleDrawerBillboard : IParticleDrawer
	{
		private CBool _isGPUBased;

		[Ordinal(1)] 
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

		public CParticleDrawerBillboard(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
