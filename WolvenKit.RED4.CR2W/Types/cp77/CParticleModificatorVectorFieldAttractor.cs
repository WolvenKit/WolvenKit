using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorVectorFieldAttractor : IParticleModificator
	{
		private CBool _inheritVelocity;
		private CBool _attract;
		private CBool _drag;
		private CHandle<IEvaluatorFloat> _restitution;

		[Ordinal(4)] 
		[RED("inheritVelocity")] 
		public CBool InheritVelocity
		{
			get
			{
				if (_inheritVelocity == null)
				{
					_inheritVelocity = (CBool) CR2WTypeManager.Create("Bool", "inheritVelocity", cr2w, this);
				}
				return _inheritVelocity;
			}
			set
			{
				if (_inheritVelocity == value)
				{
					return;
				}
				_inheritVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("attract")] 
		public CBool Attract
		{
			get
			{
				if (_attract == null)
				{
					_attract = (CBool) CR2WTypeManager.Create("Bool", "attract", cr2w, this);
				}
				return _attract;
			}
			set
			{
				if (_attract == value)
				{
					return;
				}
				_attract = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("drag")] 
		public CBool Drag
		{
			get
			{
				if (_drag == null)
				{
					_drag = (CBool) CR2WTypeManager.Create("Bool", "drag", cr2w, this);
				}
				return _drag;
			}
			set
			{
				if (_drag == value)
				{
					return;
				}
				_drag = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("restitution")] 
		public CHandle<IEvaluatorFloat> Restitution
		{
			get
			{
				if (_restitution == null)
				{
					_restitution = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "restitution", cr2w, this);
				}
				return _restitution;
			}
			set
			{
				if (_restitution == value)
				{
					return;
				}
				_restitution = value;
				PropertySet(this);
			}
		}

		public CParticleModificatorVectorFieldAttractor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
