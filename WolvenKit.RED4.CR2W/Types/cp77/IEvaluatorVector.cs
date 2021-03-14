using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IEvaluatorVector : IEvaluator
	{
		private CEnum<EFreeVectorAxes> _freeAxes;
		private CBool _spill;

		[Ordinal(0)] 
		[RED("freeAxes")] 
		public CEnum<EFreeVectorAxes> FreeAxes
		{
			get
			{
				if (_freeAxes == null)
				{
					_freeAxes = (CEnum<EFreeVectorAxes>) CR2WTypeManager.Create("EFreeVectorAxes", "freeAxes", cr2w, this);
				}
				return _freeAxes;
			}
			set
			{
				if (_freeAxes == value)
				{
					return;
				}
				_freeAxes = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("spill")] 
		public CBool Spill
		{
			get
			{
				if (_spill == null)
				{
					_spill = (CBool) CR2WTypeManager.Create("Bool", "spill", cr2w, this);
				}
				return _spill;
			}
			set
			{
				if (_spill == value)
				{
					return;
				}
				_spill = value;
				PropertySet(this);
			}
		}

		public IEvaluatorVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
