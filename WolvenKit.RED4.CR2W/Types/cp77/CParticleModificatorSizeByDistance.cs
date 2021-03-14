using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorSizeByDistance : IParticleModificator
	{
		private CHandle<IEvaluatorFloat> _nearDistanceRangeStart;
		private CHandle<IEvaluatorFloat> _nearDistanceRangeEnd;
		private CHandle<IEvaluatorFloat> _nearDistanceSizeMultiplier;
		private CHandle<IEvaluatorFloat> _farDistanceRangeStart;
		private CHandle<IEvaluatorFloat> _farDistanceRangeEnd;
		private CHandle<IEvaluatorFloat> _farDistanceSizeMultiplier;

		[Ordinal(4)] 
		[RED("nearDistanceRangeStart")] 
		public CHandle<IEvaluatorFloat> NearDistanceRangeStart
		{
			get
			{
				if (_nearDistanceRangeStart == null)
				{
					_nearDistanceRangeStart = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "nearDistanceRangeStart", cr2w, this);
				}
				return _nearDistanceRangeStart;
			}
			set
			{
				if (_nearDistanceRangeStart == value)
				{
					return;
				}
				_nearDistanceRangeStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("nearDistanceRangeEnd")] 
		public CHandle<IEvaluatorFloat> NearDistanceRangeEnd
		{
			get
			{
				if (_nearDistanceRangeEnd == null)
				{
					_nearDistanceRangeEnd = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "nearDistanceRangeEnd", cr2w, this);
				}
				return _nearDistanceRangeEnd;
			}
			set
			{
				if (_nearDistanceRangeEnd == value)
				{
					return;
				}
				_nearDistanceRangeEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("nearDistanceSizeMultiplier")] 
		public CHandle<IEvaluatorFloat> NearDistanceSizeMultiplier
		{
			get
			{
				if (_nearDistanceSizeMultiplier == null)
				{
					_nearDistanceSizeMultiplier = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "nearDistanceSizeMultiplier", cr2w, this);
				}
				return _nearDistanceSizeMultiplier;
			}
			set
			{
				if (_nearDistanceSizeMultiplier == value)
				{
					return;
				}
				_nearDistanceSizeMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("farDistanceRangeStart")] 
		public CHandle<IEvaluatorFloat> FarDistanceRangeStart
		{
			get
			{
				if (_farDistanceRangeStart == null)
				{
					_farDistanceRangeStart = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "farDistanceRangeStart", cr2w, this);
				}
				return _farDistanceRangeStart;
			}
			set
			{
				if (_farDistanceRangeStart == value)
				{
					return;
				}
				_farDistanceRangeStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("farDistanceRangeEnd")] 
		public CHandle<IEvaluatorFloat> FarDistanceRangeEnd
		{
			get
			{
				if (_farDistanceRangeEnd == null)
				{
					_farDistanceRangeEnd = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "farDistanceRangeEnd", cr2w, this);
				}
				return _farDistanceRangeEnd;
			}
			set
			{
				if (_farDistanceRangeEnd == value)
				{
					return;
				}
				_farDistanceRangeEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("farDistanceSizeMultiplier")] 
		public CHandle<IEvaluatorFloat> FarDistanceSizeMultiplier
		{
			get
			{
				if (_farDistanceSizeMultiplier == null)
				{
					_farDistanceSizeMultiplier = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "farDistanceSizeMultiplier", cr2w, this);
				}
				return _farDistanceSizeMultiplier;
			}
			set
			{
				if (_farDistanceSizeMultiplier == value)
				{
					return;
				}
				_farDistanceSizeMultiplier = value;
				PropertySet(this);
			}
		}

		public CParticleModificatorSizeByDistance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
