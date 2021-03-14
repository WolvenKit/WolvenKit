using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EmitterGroupAreaParams : CVariable
	{
		private CEnum<EEmitterGroup> _group;
		private curveData<CFloat> _emissionScale;
		private curveData<CFloat> _opacityScale;

		[Ordinal(0)] 
		[RED("group")] 
		public CEnum<EEmitterGroup> Group
		{
			get
			{
				if (_group == null)
				{
					_group = (CEnum<EEmitterGroup>) CR2WTypeManager.Create("EEmitterGroup", "group", cr2w, this);
				}
				return _group;
			}
			set
			{
				if (_group == value)
				{
					return;
				}
				_group = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("emissionScale")] 
		public curveData<CFloat> EmissionScale
		{
			get
			{
				if (_emissionScale == null)
				{
					_emissionScale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "emissionScale", cr2w, this);
				}
				return _emissionScale;
			}
			set
			{
				if (_emissionScale == value)
				{
					return;
				}
				_emissionScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("opacityScale")] 
		public curveData<CFloat> OpacityScale
		{
			get
			{
				if (_opacityScale == null)
				{
					_opacityScale = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "opacityScale", cr2w, this);
				}
				return _opacityScale;
			}
			set
			{
				if (_opacityScale == value)
				{
					return;
				}
				_opacityScale = value;
				PropertySet(this);
			}
		}

		public EmitterGroupAreaParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
