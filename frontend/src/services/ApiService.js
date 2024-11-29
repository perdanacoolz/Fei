import axios from 'axios';

const baseurl='https://stage-master.api.infoss.solusisentraldata.com/';

class ApiService{
    getAll(param) {
        return axios.get(baseurl+param);
    }

    getAllWithPaging(param) {
        return axios.get(baseurl+param+"1/20000");
    }

    getDataById(param,Id) {
        return axios.get(baseurl+param + Id);
    }

    createData(param,Data) {
        return axios.post(baseurl+param , Data);
    }

    updateData(param,Data) {
        return axios.put(baseurl+param , Data);
    }

    deleteData(param,Id) {
        let username='wahyu';
        return axios.delete(baseurl+param+Id+'/'+username);
    }
}

export default new ApiService()