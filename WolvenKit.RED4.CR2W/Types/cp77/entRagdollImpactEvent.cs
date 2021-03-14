using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entRagdollImpactEvent : redEvent
	{
		private wCHandle<entEntity> _otherEntity;
		private CBool _triggeredSimulation;
		private CArray<entRagdollImpactPointData> _impactPoints;

		[Ordinal(0)] 
		[RED("otherEntity")] 
		public wCHandle<entEntity> OtherEntity
		{
			get
			{
				if (_otherEntity == null)
				{
					_otherEntity = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "otherEntity", cr2w, this);
				}
				return _otherEntity;
			}
			set
			{
				if (_otherEntity == value)
				{
					return;
				}
				_otherEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("triggeredSimulation")] 
		public CBool TriggeredSimulation
		{
			get
			{
				if (_triggeredSimulation == null)
				{
					_triggeredSimulation = (CBool) CR2WTypeManager.Create("Bool", "triggeredSimulation", cr2w, this);
				}
				return _triggeredSimulation;
			}
			set
			{
				if (_triggeredSimulation == value)
				{
					return;
				}
				_triggeredSimulation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("impactPoints")] 
		public CArray<entRagdollImpactPointData> ImpactPoints
		{
			get
			{
				if (_impactPoints == null)
				{
					_impactPoints = (CArray<entRagdollImpactPointData>) CR2WTypeManager.Create("array:entRagdollImpactPointData", "impactPoints", cr2w, this);
				}
				return _impactPoints;
			}
			set
			{
				if (_impactPoints == value)
				{
					return;
				}
				_impactPoints = value;
				PropertySet(this);
			}
		}

		public entRagdollImpactEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
