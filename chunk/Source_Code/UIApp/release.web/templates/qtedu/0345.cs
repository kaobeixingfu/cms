�}F� 
 &   1iH��g    ��3�`"��'޲�o�{��͐k},]�a��"���(Eޜ?��A���wp�-�S�_"�y��`l�uވ�v&��P�~�>��x8��
7^Ln������1y�)��r�ꐴ��X�^�m�E�k�u�0=<�����-�P]J��m3+�e�R�lZf�Z�d�'�%gmB��4sԑ?}8����u\�Q���|k�еBb�ТT�Na�~Ĺ�$�����S�=Ĭ���5��k��ѳ{}�.7*ĊRw�tV��w���閨7.EE�W5?O��5%ҋU��g������m���9�z֓��cr@v$��0�ӀC�군��y��q
`i~S���I�L0����B��*$[��o��{�Ѷ3�q��ECA�&Z�#d	�jLa�+��0mO�cn��ݰy�����|o��#����X�b�;��}�I���%Ɗ��A�����=h��j��X��T*JCN�e���hfp���L�߂troller = "QtEdu", action = "SchoolIndex" },
            new { area = "^[a-zA-z]{2}$" }
            );
    }

    public void SchoolIndex(string area)
    {
        if (file.Contains(area))
        {
            string html=PageUtility.Require("/default/school", new
            {
                name=file[area],
                area=area
            });

            base.Render(html);
        }
        else
        {
           base.Category(area);
        }
    }

}

