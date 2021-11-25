

Public Class WebFormNit
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles btnValidNit.Click

        'Servicio: https://www.ingface.net:443/ServiciosIngface/ingfaceWsServices

        'Parametros que recibe el metodo

        'Usuario
        Dim user_n As String = "CONSUMO_NIT"
        'Contraseña
        Dim password_n As String = "58B45D8740C791420C53A49FFC924A1B58B45D8740C791420C53A49FFC924A1B"
        'Nit valido
        ' Dim nit_n As String = "12521337"

        'Nit recibido en TextBox
        Dim nit_n2 As String = txtNit.Text

        Dim res_v As Byte

        'Instancia del servico
        Dim wsif As Service_Infile.ingfaceWsServicesClient = New Service_Infile.ingfaceWsServicesClient()
        'Se invoca al metodo del WS que valida el Nit y se envian los parametros necesarios
        Dim res_n = wsif.nitContribuyentes(user_n, password_n, nit_n2)

        'se obtien el nombre correspondiente al nit
        Dim nomnre_n As String = res_n.nombre
        'Se obtiene la direccion correspondiente al nit
        Dim direccion_n As String = res_n.direccion_completa

        'EL metodo nitContribuyentes devuelve en nitContribuyentes.nombre NIT NO VALIDO si el nit no es correcto
        'Validacion del NIT
        If res_n.nombre.ToString <> "Nit no valido" Then
            'si el nit es valido
            res_v = 1
        Else
            'si el nit es invalido
            res_v = 0
        End If

        'Acciones si el Nit es valido o invalido
        If res_v = 1 Then
            lblValidNit.Text = "Nit valido"

            lblNombre.Visible = True
            lblDireccion.Visible = True
            lblNombre_R.Visible = True
            lblDireccion_R.Visible = True

            'Datos del NIT
            'Nombre
            lblNombre_R.Text = nomnre_n
            'Direccion
            lblDireccion_R.Text = direccion_n
        Else
            lblValidNit.Text = "Nit no valido"
            lblNombre.Visible = False
            lblDireccion.Visible = False
            lblNombre_R.Visible = False
            lblDireccion_R.Visible = False
        End If

    End Sub

End Class