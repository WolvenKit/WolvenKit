using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorOrbit : IParticleModificator
	{
		private CHandle<IEvaluatorVector> _offset;
		private CHandle<IEvaluatorVector> _frequency;
		private CHandle<IEvaluatorVector> _phase;
		private CBool _overridePosition;

		[Ordinal(4)] 
		[RED("offset")] 
		public CHandle<IEvaluatorVector> Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (CHandle<IEvaluatorVector>) CR2WTypeManager.Create("handle:IEvaluatorVector", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("frequency")] 
		public CHandle<IEvaluatorVector> Frequency
		{
			get
			{
				if (_frequency == null)
				{
					_frequency = (CHandle<IEvaluatorVector>) CR2WTypeManager.Create("handle:IEvaluatorVector", "frequency", cr2w, this);
				}
				return _frequency;
			}
			set
			{
				if (_frequency == value)
				{
					return;
				}
				_frequency = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("phase")] 
		public CHandle<IEvaluatorVector> Phase
		{
			get
			{
				if (_phase == null)
				{
					_phase = (CHandle<IEvaluatorVector>) CR2WTypeManager.Create("handle:IEvaluatorVector", "phase", cr2w, this);
				}
				return _phase;
			}
			set
			{
				if (_phase == value)
				{
					return;
				}
				_phase = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("overridePosition")] 
		public CBool OverridePosition
		{
			get
			{
				if (_overridePosition == null)
				{
					_overridePosition = (CBool) CR2WTypeManager.Create("Bool", "overridePosition", cr2w, this);
				}
				return _overridePosition;
			}
			set
			{
				if (_overridePosition == value)
				{
					return;
				}
				_overridePosition = value;
				PropertySet(this);
			}
		}

		public CParticleModificatorOrbit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
