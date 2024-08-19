using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GodTextController : MonoBehaviour
{
    public Transform _canvas;
    Transform _oneGodOn,_theeGodOn,_oldTeam,_otherTeam, _handsomeTeam,_youngTeam, _introduce,_godOpen, _introduceText;
    public bool TC = true;
    // Start is called before the first frame update
    void Start()
    {
        _theeGodOn = _canvas.Find("��ܲ�");
        _oneGodOn = _canvas.Find("��@��ܲ�");
        _oldTeam = _theeGodOn.Find("�T�Ѥ���");
        _otherTeam = _theeGodOn.Find("�T�f����");
        _handsomeTeam = _theeGodOn.Find("�T�Ӥ���");
        _youngTeam= _theeGodOn.Find("�T�֤���");
        _introduce= _theeGodOn.Find("���Ф奻");
        _introduceText = _oneGodOn.Find("��@���Ф奻");
    }

    // Update is called once per frame
    void Update()
    {
        if (_oldTeam.gameObject.activeInHierarchy)
        {
            _introduce.GetComponent<Text>().text = "���L�ζH�����~�ѡA�ҥH�٤����u�T�ѡv���ݡC";

        }
        if (_otherTeam.gameObject.activeInHierarchy)
        {
            _introduce.GetComponent<Text>().text = "�T����ݬ��ݤ����~���f���H��A�ҥH�٤����u�T�f�v���ݡC";

        }
        if (_handsomeTeam.gameObject.activeInHierarchy)
        {
            _introduce.GetComponent<Text>().text = "�b�Ѯx��¾�Ȭ��x�v�ΰ���̡A�ҥH�٤����u�T�ӡv���ݡC";

        }
        if (_youngTeam.gameObject.activeInHierarchy)
        {
            _introduce.GetComponent<Text>().text = "�L�̬O�ߤT�S���GŽ���d���A�~���ݰ_�Ӹ����~���A�]�Ӧ��u�T�֤��ݡv���١C";

        }
        if (TC && _oneGodOn.gameObject.activeInHierarchy)
        {
            switch (ButtonClickHandler.ChooseGod)
            {
                case "�i�d��":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "�y�i�d���z�A���y�l�~�z���Ȧ~����ʬ�D���A�O�Ѯx�ɬӤj�Ҥ��x�v�A�P�ɥ�O�c�d�����x�v�A�]�O�y���~�d���z���Ʀ�ġ��@���쪺���ݡC�t�Ϥd��鬰�A��T��|��C���L�y���������ζ­��B���GŽ�B��T���y���B�Y����ҴU�B���ۦ̶���ξ���s�T�C¾�x���x�ޭ��~��~�A�G�\���B���~�~�i�D���O���C�O�y���~�d���z�Q�G���ݤ����y�T�Ӥ��ݡz���@�C";
                    break;
                case "�}�d��":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "�y�}�d���z�A���y���~�z���Ȧ~����ʬ�D���A���Ѯx�ɬӤj�Ҥ��x�v�A��O�y���~�d���z���Ʀ�ġ��G���쪺���ݡA��t�Ϥd��鬰 �A��K��T�� �C���L�y�����������GŽ�B��T���y���B�Y�����I�۴U�B���۶¦��s�T�C¾�x������B�a�z�A�]�O�@�x¾�̡B���N�N��ϨD�ʤɤ������C�O�y���~�d���z�Q�G���ݤ����y�T�Ӥ��ݡz���@�C";
                    break;
                case "�J�d��":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "�y�J�d���z�A���y�G�~�z���Ȧ~����ʬ�D���A�O�y���~�d���z���Ʀ�ġ��T���쪺���ݡA�]�O�f���H�󪺤��ݡA��t�Ϥd��鬰�A�䤭�뤭��C���L�y�����C���q���񨧦�r�᭱���GŽ�B�Z�Ҩ��y���B�Y���T�ͤ��U�B���۫C����s�T�F¾�x�G��������A�D�樮���w�C�O�y���~�d���z�Q�G���ݤ����y�T�f���ݡz���@�C";
                    break;
                case "�դd��":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "�y�դd���z�A���y�f�~�z���Ȧ~����ʬ�D���A�O�y���~�d���z���Ʀ�ġ��|���쪺���ݡA�]�O�~�������ݡA��t�Ϥd��鬰�A�䤭��C��C���L�y���������q�����r�L�GŽ�B��T���y���B�Y���|�����a�B���۬����s�T�C¾�x����x�q�B�O�������x�q�x�Z�A�������󱡡B�z�B�k�����������U�C�O�y���~�d���z�Q�G���ݤ����y�T�֤��ݡz���@�C";
                    break;
                case "�d�d��":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "�y�d�d���z�A���y���~�z���Ȧ~����ʬ�D���A�O�y���~�d���z���Ʀ�ġ������쪺���ݡA�]�O��Ѫ����ݡA��t�Ϥd��鬰�A��T��T��C���L�y�����������GŽ�B��Z�Ҩ��y���B�Y���T�ͤ��U�B���۪������s�T�C¾�x���D�A�~�צ��B�b�������A�O�A�B���B�b���~���u�@���C�O�y���~�d���z�Q�G���ݤ����y�T�Ѥ��ݡq�d�B��B���r�z���@�C";
                    break;
                case "��d��":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "�y��d���z�A���y�x�~�z���Ȧ~����ʬ�D���A�O�y���~�d���z���Ʀ�ġ������쪺���ݡA�]�O��Ѫ����ݡA��t�Ϥd��鬰�A��K��Q�G�� �C���L�y�����������GŽ�B��T���y���B�Y����ҴU�B���ۦ̶���ξ���s�T�C¾�x���O�򤶷~�D�ЫΡB�g�a���ʡB�P�ⶶ�Q�����C�O�y���~�d���z�Q�G���ݤ����y�T�Ѥ��ݡz���@�C";
                    break;
                case "���d��":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "�y���d���z�A���y�Ȧ~�z���Ȧ~����ʬ�D���A�O�y���~�d���z�Q�G���ݤ����y�T�֤��ݡz���@�A��O�y���~�d���z���Ʀ�ġ��C���쪺���ݡA�]�O�f���H�󪺤��ݡA��t�Ϥd��鬰�A�䤭��@��C���L�y���������B�L�GŽ�B��Z�Ҩ��y���B�Y���G�s�a�B���۪������s�T�C¾�x���D�\�W�Q�S�B�Ƿ~���i�C�O�y���~�d���z�Q�G���ݤ����y�T�֤��ݡz���@�C";
                    break;
                case "�ʤd��":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "�y�ʤd���z�A���y���~�z���Ȧ~����ʬ�D���A�O�y���~�d���z���Ʀ�ġ��K���쪺���ݡA�]�O�f���H�󪺤��ݡA��t�Ϥd��鬰�A�䤭��@��C���L�y�����©��᭱���GŽ�B�Z�Ҩ��y���B�Y�����ӴU�B���۬����s�T�C¾�x����p�H�B���B����p�H�t�`�A��O�a�x�M�ӡC�O�y���~�d���z�Q�G���ݤ����y�T�f���ݡz���@�C";
                    break;
                case "���d��":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "�y���d���z�A���y�Ӧ~�z���Ȧ~����ʬ�D���A�O�y���~�d���z�Q�G���ݤ����y�T�Ѥ��ݡz���@�A��O�y���~�d���z���Ʀ�ġ��E���쪺���ݡA�]�O��Ѫ����ݡA��t�Ϥd��鬰�A��T��K�� �C���L�y�����������GŽ�B��Z�Ҩ��y���B�Y����ҴU�B���۪�����ξ���s�T�C¾�x���O���x�Bĵ�l�̨D¾���w�B�O�D�ʤɤ������C �O�y���~�d���z�Q�G���ݤ����y�T�Ѥ��ݡz���@�C";
                    break;
                case "�Ӥd��":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "�y�Ӥd���z�A���y���~�z���Ȧ~����ʬ�D���A�O�y���~�d���z���Ʀ�ġ� �Q�� �쪺���ݡA�]�O�f���H�󪺤��ݡA��t�Ϥd��鬰�A��Q�G��@�� �C���L�y���������q�����r�᭱���GŽ�B�Z�Ҩ��y���B�Y���|�����a�B���۶¦��s�T�C¾�x���Z���a�B�Ѥ̡B��١A�θg�L��a���쳱�٨��Z�A���i�D���O���C�O�y���~�d���z�Q�G���ݤ����y�T�f���ݡz���@�C";
                    break;
                case "�c�d��":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "�y�c�d���z�A���y���~�z���Ȧ~����ʬ�D���A�Q�G���ݤ��v�O�̤j�A�^���x�ޤѽL�A��O�y���~�d���z���Ʀ�ġ��Q�@���쪺���ݡC��t�Ϥd��鬰�A�䤭��Q�G�� �C���L�y���������q�����r���GŽ�B��T���y���B�@�y�q�ءz���B�Y����ҴU�B���ۦ̶����s�T�C¾�x���H�̨D��B�O���骺�����C�O�y���~�d���z�Q�G���ݤ����y�T�Ӥ��ݡz���@�C";
                    break;
                case "ù�d��":
                    _godOpen = _oneGodOn.Find(ButtonClickHandler.ChooseGod);
                    _godOpen.gameObject.SetActive(true);
                    _introduceText.GetComponent<Text>().text = "�yù�d���z�A���y��~�z���Ȧ~����ʬ�D���A�O�y���~�d���z�Q�G���ݤ����y�T�֤��ݡz���@�A��O�y���~�d���z���Ʀ�ġ��Q�G���쪺���ݡA�]�O�̦~�������ݡA��t�Ϥd��鬰�A�䥿��Q�G�� �C�yù�d���z�����L�y���A�������L�GŽ�B�Z�Ҩ��y���B�Y���G�s�a�B���۬����s�T�C¾�x���O�H�̨D�g�Ӷ��Q�B�q�ӿ����B�ͷN�����������C�O�y���~�d���z�Q�G���ݤ����y�T�֤��ݡz���@�C";
                    break;
            }
            TC = false;

        }
        if (!TC && ! _oneGodOn.gameObject.activeInHierarchy)
        {
            _godOpen.gameObject.SetActive(false);
            TC = true;
        }
    }
}
