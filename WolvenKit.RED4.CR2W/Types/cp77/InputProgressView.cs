using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InputProgressView : inkWidgetLogicController
	{
		private wCHandle<inkImageWidget> _targetImage;
		private CInt32 _progressPercent;
		private CString _partName;

		[Ordinal(1)] 
		[RED("TargetImage")] 
		public wCHandle<inkImageWidget> TargetImage
		{
			get
			{
				if (_targetImage == null)
				{
					_targetImage = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "TargetImage", cr2w, this);
				}
				return _targetImage;
			}
			set
			{
				if (_targetImage == value)
				{
					return;
				}
				_targetImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ProgressPercent")] 
		public CInt32 ProgressPercent
		{
			get
			{
				if (_progressPercent == null)
				{
					_progressPercent = (CInt32) CR2WTypeManager.Create("Int32", "ProgressPercent", cr2w, this);
				}
				return _progressPercent;
			}
			set
			{
				if (_progressPercent == value)
				{
					return;
				}
				_progressPercent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("PartName")] 
		public CString PartName
		{
			get
			{
				if (_partName == null)
				{
					_partName = (CString) CR2WTypeManager.Create("String", "PartName", cr2w, this);
				}
				return _partName;
			}
			set
			{
				if (_partName == value)
				{
					return;
				}
				_partName = value;
				PropertySet(this);
			}
		}

		public InputProgressView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
