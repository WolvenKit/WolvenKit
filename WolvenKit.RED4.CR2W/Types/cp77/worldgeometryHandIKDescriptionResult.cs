using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldgeometryHandIKDescriptionResult : CVariable
	{
		private Vector4 _grabPointStart;
		private Vector4 _grabPointEnd;

		[Ordinal(0)] 
		[RED("grabPointStart")] 
		public Vector4 GrabPointStart
		{
			get
			{
				if (_grabPointStart == null)
				{
					_grabPointStart = (Vector4) CR2WTypeManager.Create("Vector4", "grabPointStart", cr2w, this);
				}
				return _grabPointStart;
			}
			set
			{
				if (_grabPointStart == value)
				{
					return;
				}
				_grabPointStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("grabPointEnd")] 
		public Vector4 GrabPointEnd
		{
			get
			{
				if (_grabPointEnd == null)
				{
					_grabPointEnd = (Vector4) CR2WTypeManager.Create("Vector4", "grabPointEnd", cr2w, this);
				}
				return _grabPointEnd;
			}
			set
			{
				if (_grabPointEnd == value)
				{
					return;
				}
				_grabPointEnd = value;
				PropertySet(this);
			}
		}

		public worldgeometryHandIKDescriptionResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
