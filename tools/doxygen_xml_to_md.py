"""generate_docs.py

Scans a directory for Doxygen-generated XML files whose names start with "class",
parses every method (memberdef kind="function") out of them, and writes a single
flat GitBook-style Markdown file with two sections:
  - Overview: namespace-organized list of methods with summaries
  - Detailed: full documentation for each method, organized by namespace

Usage:
    python generate_docs.py <input_directory> [output_file.md]

    input_directory  – folder containing the doxygen XML files
    output_file.md   – (optional) path to write; defaults to "docs.md" in CWD
"""

import sys
import os
import xml.etree.ElementTree as ET
from pathlib import Path
from collections import defaultdict

# ---------------------------------------------------------------------------
# Helpers
# ---------------------------------------------------------------------------

def collect_text(element: ET.Element | None) -> str:
    """Recursively collect all text content from an XML element, stripping
    surrounding whitespace. Returns an empty string if the element is None."""
    if element is None:
        return ""
    # itertext() yields every text fragment in document-order (including tails)
    return " ".join(element.itertext()).strip()


def extract_docs(memberdef: ET.Element) -> dict:
    """Parse briefdescription and detaileddescription into three distinct buckets:
    Returns a dict:
        summary – str, the high-level description from <briefdescription>
        params  – list of (name: str, description: str) tuples, from <parameterlist>
        returns – str, the return description from <simplesect kind="return">
    """
    # --- Summary: plain text from briefdescription <para> elements ----------
    summary_parts: list[str] = []
    brief = memberdef.find("briefdescription")
    if brief is not None:
        for para in brief.iter("para"):
            text = collect_text(para).strip()
            if text:
                summary_parts.append(text)
    summary = " ".join(summary_parts)

    # --- Params & Returns: live inside detaileddescription -----------------
    params: list[tuple[str, str]] = []
    returns: str = ""

    detailed = memberdef.find("detaileddescription")
    if detailed is not None:
        # <parameterlist kind="param"> → one <parameteritem> per param
        for paramlist in detailed.iter("parameterlist"):
            if paramlist.get("kind") != "param":
                continue
            for item in paramlist.findall("parameteritem"):
                # Name is inside <parameternamelist><parametername>
                name_el = item.find(".//parametername")
                name = (name_el.text or "").strip() if name_el is not None else ""
                # Description is inside <parameterdescription>
                desc = collect_text(item.find("parameterdescription")).strip()
                if name:
                    params.append((name, desc))

        # <simplesect kind="return"> → single return description
        for simplesect in detailed.iter("simplesect"):
            if simplesect.get("kind") == "return":
                returns = collect_text(simplesect).strip()

    return {"summary": summary, "params": params, "returns": returns}


def build_signature(memberdef: ET.Element) -> str:
    """Build a clean, presentable signature using only the short method name.
    Format:
        MethodName(param1: Type1, param2: Type2 = default) → ReturnType
    """
    ret_type = collect_text(memberdef.find("type")).strip()
    method_name = (memberdef.findtext("name") or "").strip()

    # Parameters in "name: Type" style, which reads more naturally
    params: list[str] = []
    for param in memberdef.findall("param"):
        p_type = collect_text(param.find("type")).strip()
        p_name = (param.findtext("declname") or "").strip()
        p_default = (param.findtext("defval") or "").strip()

        if p_name:
            token = f"{p_name}: {p_type}"
        else:
            token = p_type
        if p_default:
            token += f" = {p_default}"
        params.append(token)

    params_str = ", ".join(params)
    signature = f"{method_name}({params_str})"

    # Append return type with an arrow, skip for constructors (no return type)
    if ret_type:
        signature += f" → {ret_type}"

    return signature


def extract_class_name(memberdef: ET.Element) -> str:
    """Extract the class name from the qualified name.
    If there's no class, return 'Global'."""
    qualified = (memberdef.findtext("qualifiedname") or "").strip()
    # qualifiedname can be "Namespace::Class::Method" or "Namespace.Class.Method"
    # depending on language — normalise to a single separator before splitting
    parts = qualified.replace("::", ".").split(".")

    # The class name is the second-to-last part (before the method name)
    if len(parts) >= 2:
        return parts[-2]
    return "Global"


def get_method_name(memberdef: ET.Element) -> str:
    """Get the simple method name."""
    return (memberdef.findtext("name") or "").strip()


def is_constructor(memberdef: ET.Element) -> bool:
    """Doxygen marks constructors as functions with no <type> and where the
    method name matches the last segment of the qualified class name."""
    ret_type = collect_text(memberdef.find("type")).strip()
    if ret_type:
        return False  # constructors have no return type

    name = (memberdef.findtext("name") or "").strip()
    qualified = (memberdef.findtext("qualifiedname") or "").strip()
    # qualifiedname can be "Namespace::Class::Method" or "Namespace.Class.Method"
    # depending on language — normalise to a single separator before splitting
    parts = qualified.replace("::", ".").split(".")
    class_name = parts[-2] if len(parts) >= 2 else ""

    return name == class_name


def strip_generics(name: str) -> str:
    """Remove generic type parameters from a method name for display purposes.
    E.g. 'GetComponent<T>' → 'GetComponent', 'Foo<T, U>' → 'Foo'.
    Names without angle brackets are returned unchanged."""
    bracket = name.find("<")
    if bracket != -1:
        return name[:bracket]
    return name


def make_anchor(text: str) -> str:
    """Convert a text string to a GitBook-compatible anchor.
    GitBook uses lowercase anchors with hyphens for spaces."""
    # Convert to lowercase and replace spaces/dots with hyphens
    anchor = text.lower().replace(" ", "-").replace(".", "-").replace("::", "-")
    # Remove parentheses and other special characters
    anchor = "".join(c for c in anchor if c.isalnum() or c == "-")
    # Remove multiple consecutive hyphens
    while "--" in anchor:
        anchor = anchor.replace("--", "-")
    return anchor.strip("-")


def extract_namespace_summary(xml_path: Path) -> str:
    """Extract namespace-level documentation from the compounddef element.
    This looks for briefdescription at the class/namespace level."""
    tree = ET.parse(xml_path)
    root = tree.getroot()

    # Look for the compounddef element (represents the class/namespace)
    compounddef = root.find("compounddef")
    if compounddef is None:
        return ""

    # Get brief description for the compound (class/namespace)
    brief = compounddef.find("briefdescription")
    if brief is not None:
        summary_parts = []
        for para in brief.iter("para"):
            text = collect_text(para).strip()
            if text:
                summary_parts.append(text)
        return " ".join(summary_parts)

    return ""


# ---------------------------------------------------------------------------
# Core
# ---------------------------------------------------------------------------

def parse_class_xml(xml_path: Path) -> tuple[str, list[dict]]:
    """Parse a single doxygen class XML file and return the class summary
    and a list of method dicts, each with keys:
        class_name, method_name, signature, docs (dict with summary/params/returns).
    Constructors are skipped."""
    tree = ET.parse(xml_path)
    root = tree.getroot()

    methods: list[dict] = []
    class_summary = ""

    for memberdef in root.iter("memberdef"):
        if memberdef.get("kind") != "function":
            continue
        if is_constructor(memberdef):
            continue

        class_name = extract_class_name(memberdef)
        method_name = get_method_name(memberdef)
        signature = build_signature(memberdef)
        docs = extract_docs(memberdef)

        methods.append({
            "class_name": class_name,
            "method_name": method_name,
            "signature": signature,
            "docs": docs
        })

    # Extract class summary once per file
    if methods:
        class_summary = extract_namespace_summary(xml_path)

    return class_summary, methods


def organize_by_class(all_methods: list[dict]) -> dict:
    """Organize methods by class name.
    Returns a dict: {class_name: [method_dict, ...]}"""
    by_class = defaultdict(list)
    for method in all_methods:
        by_class[method["class_name"]].append(method)
    return dict(by_class)


def get_unique_methods_for_overview(methods: list[dict]) -> list[dict]:
    """Filter methods to only include the first occurrence of each method name.
    This handles overloaded methods by only showing the first one in the overview."""
    seen_names = set()
    unique_methods = []

    for method in methods:
        if method["method_name"] not in seen_names:
            seen_names.add(method["method_name"])
            unique_methods.append(method)

    return unique_methods


def generate_markdown(all_methods: list[dict], class_summaries: dict) -> str:
    """Generate markdown with Overview and Detailed sections, organized by class."""
    md_lines: list[str] = []

    # Organize methods by class
    by_class = organize_by_class(all_methods)

    # Sort classes alphabetically
    sorted_classes = sorted(by_class.keys())

    # -------------------------------------------------------------------------
    # OVERVIEW SECTION
    # -------------------------------------------------------------------------
    md_lines.append("# Overview")
    md_lines.append("")

    for class_name in sorted_classes:
        methods = by_class[class_name]

        # Filter to unique methods (first occurrence only for overloads)
        unique_methods = get_unique_methods_for_overview(methods)

        # Class header (links to detailed section)
        md_lines.append(f"## {class_name}")
        md_lines.append("")

        # Class summary
        if class_name in class_summaries and class_summaries[class_name]:
            md_lines.append(class_summaries[class_name])
            md_lines.append("")

        # List of methods with their summaries (markdown table)
        md_lines.append("| Method | Description |")
        md_lines.append("|--------|-------------|")
        for method in unique_methods:
            display_name = strip_generics(method["method_name"])
            method_anchor = make_anchor(display_name)
            summary = method["docs"]["summary"] or "No description available."
            # Escape pipe characters in summary
            summary_safe = summary.replace("|", "\\|")
            md_lines.append(f'| [{display_name}](#{method_anchor}) | {summary_safe} |')
        md_lines.append("")

    md_lines.append("---")
    md_lines.append("")

    # -------------------------------------------------------------------------
    # DETAILED SECTION
    # -------------------------------------------------------------------------
    md_lines.append("# Detailed Documentation")
    md_lines.append("")

    for class_name in sorted_classes:
        class_anchor = make_anchor(class_name)
        methods = by_class[class_name]

        # Class header
        md_lines.append(f"## {class_name}")
        md_lines.append("")

        # Class summary
        if class_name in class_summaries and class_summaries[class_name]:
            md_lines.append(class_summaries[class_name])
            md_lines.append("")

        # Each method in detail
        for method in methods:
            display_name = strip_generics(method["method_name"])
            method_anchor = make_anchor(display_name)
            docs = method["docs"]

            # Method header with anchor
            md_lines.append(f"### {display_name}")
            md_lines.append("")

            # Summary as a blockquote (only if present)
            if docs["summary"]:
                md_lines.append(f"> {docs['summary']}")
                md_lines.append("")

            # Parameters as a table (only if any exist)
            if docs["params"]:
                md_lines.append("| Parameter | Description |")
                md_lines.append("|-----------|-------------|")
                for name, desc in docs["params"]:
                    # Escape any pipe characters in the description
                    desc_safe = desc.replace("|", "\\|") if desc else "—"
                    md_lines.append(f"| `{name}` | {desc_safe} |")
                md_lines.append("")

            # Return value as a bold label + inline text
            if docs["returns"]:
                md_lines.append(f"**Returns:** {docs['returns']}")
                md_lines.append("")

            # Signature
            md_lines.append("```csharp")
            md_lines.append(method["signature"])
            md_lines.append("```")
            md_lines.append("")
            md_lines.append("---")
            md_lines.append("")

        md_lines.append("")

    return "\n".join(md_lines)


def main() -> None:
    if len(sys.argv) < 2:
        print(__doc__)
        sys.exit(1)

    input_dir = Path(sys.argv[1]).resolve()
    output_path = Path(sys.argv[2]).resolve() if len(sys.argv) > 2 else Path("docs.md").resolve()

    if not input_dir.is_dir():
        print(f"Error: '{input_dir}' is not a directory.")
        sys.exit(1)

    # Collect all XML files whose *stem* starts with "class"
    xml_files = sorted(
        f for f in input_dir.iterdir()
        if f.suffix.lower() == ".xml" and f.stem.startswith("class")
    )

    if not xml_files:
        print(f"No XML files starting with 'class' found in '{input_dir}'.")
        sys.exit(0)

    all_methods: list[dict] = []
    class_summaries: dict[str, str] = {}

    for xml_file in xml_files:
        print(f"  Parsing {xml_file.name} …")
        class_summary, methods = parse_class_xml(xml_file)
        all_methods.extend(methods)

        # Store class summary (only keep first one if multiple files have same class)
        for method in methods:
            class_name = method["class_name"]
            if class_name not in class_summaries and class_summary:
                class_summaries[class_name] = class_summary

    if not all_methods:
        print("No methods found in any of the parsed files.")
        sys.exit(0)

    markdown = generate_markdown(all_methods, class_summaries)
    output_path.write_text(markdown, encoding="utf-8")

    print(f"\nDone — {len(all_methods)} method(s) written to {output_path}")


if __name__ == "__main__":
    main()
