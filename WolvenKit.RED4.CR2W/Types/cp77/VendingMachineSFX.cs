using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendingMachineSFX : CVariable
	{
		private CName _glitchingStart;
		private CName _glitchingStop;

		[Ordinal(0)] 
		[RED("glitchingStart")] 
		public CName GlitchingStart
		{
			get
			{
				if (_glitchingStart == null)
				{
					_glitchingStart = (CName) CR2WTypeManager.Create("CName", "glitchingStart", cr2w, this);
				}
				return _glitchingStart;
			}
			set
			{
				if (_glitchingStart == value)
				{
					return;
				}
				_glitchingStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("glitchingStop")] 
		public CName GlitchingStop
		{
			get
			{
				if (_glitchingStop == null)
				{
					_glitchingStop = (CName) CR2WTypeManager.Create("CName", "glitchingStop", cr2w, this);
				}
				return _glitchingStop;
			}
			set
			{
				if (_glitchingStop == value)
				{
					return;
				}
				_glitchingStop = value;
				PropertySet(this);
			}
		}

		public VendingMachineSFX(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
