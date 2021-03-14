using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInkChoiceVisualizer : gameuiIChoiceVisualizer
	{
		private CBool _isDynamic;
		private CEnum<gameuiChoiceListVisualizerType> _type;

		[Ordinal(0)] 
		[RED("isDynamic")] 
		public CBool IsDynamic
		{
			get
			{
				if (_isDynamic == null)
				{
					_isDynamic = (CBool) CR2WTypeManager.Create("Bool", "isDynamic", cr2w, this);
				}
				return _isDynamic;
			}
			set
			{
				if (_isDynamic == value)
				{
					return;
				}
				_isDynamic = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gameuiChoiceListVisualizerType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gameuiChoiceListVisualizerType>) CR2WTypeManager.Create("gameuiChoiceListVisualizerType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public gameuiInkChoiceVisualizer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
