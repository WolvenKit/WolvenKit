using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorDrag : IParticleModificator
	{
		private CHandle<IEvaluatorFloat> _dragCoefficient;
		private CFloat _scale;

		[Ordinal(4)] 
		[RED("dragCoefficient")] 
		public CHandle<IEvaluatorFloat> DragCoefficient
		{
			get
			{
				if (_dragCoefficient == null)
				{
					_dragCoefficient = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "dragCoefficient", cr2w, this);
				}
				return _dragCoefficient;
			}
			set
			{
				if (_dragCoefficient == value)
				{
					return;
				}
				_dragCoefficient = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (CFloat) CR2WTypeManager.Create("Float", "scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		public CParticleModificatorDrag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
